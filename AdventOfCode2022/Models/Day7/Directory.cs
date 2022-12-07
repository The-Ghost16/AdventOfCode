// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Directory.cs" company="">
//   
// </copyright>
// <summary>
//   The directory.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AdventOfCode2022.Models.Day7
{
    /// <summary>
    /// The directory.
    /// </summary>
    internal class Directory
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the parent.
        /// </summary>
        public Directory? Parent { get; set; } = null;

        /// <summary>
        /// Gets or sets the directories.
        /// </summary>
        public IList<Directory> Directories { get; set; } = new List<Directory>();

        /// <summary>
        /// Gets or sets the files.
        /// </summary>
        public IList<File> Files { get; set; } = new List<File>();

        /// <summary>
        /// The size.
        /// </summary>
        public int Size => Directories.Sum(d => d.Size) + Files.Sum(f => f.Size);
    }
}