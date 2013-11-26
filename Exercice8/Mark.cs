
namespace Exercice8
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Represents a mark.
    /// </summary>
    public class Mark
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mark"/> class.
        /// </summary>
        public Mark()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Mark"/> class.
        /// </summary>
        /// <param name="minimum">The minimum.</param>
        /// <param name="maximum">The maximum.</param>
        /// <param name="value">The value.</param>
        public Mark(int minimum, int maximum, int value)
        {
            this.Minimun = minimum;
            this.Maximum = maximum;
            this.Value = value;
        }

        /// <summary>
        /// Gets or sets the minimun.
        /// </summary>
        public int Minimun { get; set; }

        /// <summary>
        /// Gets or sets the maximum.
        /// </summary>
        public int Maximum { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Gets a collection of fake marks.
        /// </summary>
        /// <returns></returns>
        public static IList<Mark> GetMarks()
        {
            return new List<Mark>()
            {
                new Mark(1, 4, 2),
                new Mark(1, 4, 1),
                new Mark(1, 4, 3),
                new Mark(1, 4, 4),
                new Mark(1, 4, 2),
                new Mark(1, 4, 1),
                new Mark(1, 4, 2),
                new Mark(1, 4, 4),
                new Mark(1, 4, 4),
                new Mark(1, 4, 3),
                new Mark(1, 4, 3),
                new Mark(1, 4, 1),
                new Mark(1, 4, 1),

                new Mark(0, 20, 02),
                new Mark(0, 20, 82),
                new Mark(0, 20, 12),
                new Mark(0, 20, 06),
                new Mark(0, 20, 16),
                new Mark(0, 20, 07),
                new Mark(0, 20, 20),
                new Mark(0, 20, 15),
                new Mark(0, 20, 05),
                new Mark(0, 20, 01),
                new Mark(0, 20, 10),
                new Mark(0, 20, 10),
                new Mark(0, 20, 14),
                new Mark(0, 20, 14),
                new Mark(0, 20, 04),

                new Mark(-100, 100, 90),
                new Mark(-100, 100, 72),
                new Mark(-100, 100, 37),
                new Mark(-100, 100, 20),
                new Mark(-100, 100, 22),
                new Mark(-100, 100, 15),
                new Mark(-100, 100, -95),
                new Mark(-100, 100, -20),
                new Mark(-100, 100, -60),
                new Mark(-100, 100, -14),
                new Mark(-100, 100, -04),
                new Mark(-100, 100, -75),
            };
        }
    }
}
