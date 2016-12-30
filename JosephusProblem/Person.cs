using System;

namespace JosephusProblem
{
    /// <summary>
    ///     There are n soldiers numbered 1 to n = Position.
    ///     Each k-th soldier will be eliminated = IsAlive.
    ///     Count starts with soldier 1.
    ///     What is the number of the last survivor?
    ///     http://www.danvk.org/josephus.html
    /// 
    ///     CATEGORY: ??
    /// </summary>
    public class Person
    {
        /// <summary>
        ///     Constructor
        /// </summary>
        public Person(int position)
        {
            Position = position;
            IsAlive = true;
        }

        /// <summary>
        ///     Position 1 to n
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        ///     Alive or killed
        /// </summary>
        public bool IsAlive { get; set; }

        /// <summary>
        ///     Next soldier
        ///     Null => this person is last
        /// </summary>
        public Person NextPerson { get; set; }

        /// <summary>
        ///     Recursive method to create a chain of people.
        ///     Terms: Current, Next (no knowledge of Previous)
        ///     Precondition: Current person is created.
        /// </summary>
        /// <param name="n">Count of person to create</param>
        /// <returns>Current </returns>
        public Person CreateChain(int n)
        {
            // Is count valid?
            if (n <= 0)
            {
                return this;
            }

            // Create next person
            // Call CreateChain on next person

            NextPerson = new Person(Position + 1);
            return NextPerson.CreateChain(n - 1);
        }

        /// <summary>
        /// Kills in a circle, getting every k-th living person
        /// When a single survivor is left, return it.
        /// 
        /// Precondition: Circular chain => NextPerson cannot be null.
        /// </summary>
        /// <param name="k">Constant</param>
        /// <param name="tagCount"></param>
        /// <param name="countAlive"></param>
        public Person Kill( int k, int tagCount, int countAlive)
        {
            if (NextPerson == null)
            {
                throw new Exception("Precondition failed: I don't have a next person to call.");
            }

            // Current person is not in sequence if not alive
            // Pass it to next person
            if (!IsAlive )
            {
                return NextPerson.Kill(k, tagCount, countAlive);
            }
            else
            {
                // Am I the last one?
                if (countAlive == 1)
                {
                    return this;
                }
                if (tagCount == k)
                {
                    // Another one bites the dust
                    IsAlive = false;
                    tagCount = 1;
                    countAlive -= 1;
                    return NextPerson.Kill(k, tagCount, countAlive);
                }
                else
                {
                    tagCount++;
                    return NextPerson.Kill(k, tagCount, countAlive);
                }
            }

            //throw new Exception( "Unknown state at Person {this}" );
        }

        /// <summary>
        ///     Description
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ($"Position={Position} IsAlive={IsAlive}");
        }
    }
}