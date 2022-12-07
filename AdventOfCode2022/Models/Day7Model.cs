// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Day7Model.cs" company="">
//   
// </copyright>
// <summary>
//   The day 7 model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------


using Directory = AdventOfCode2022.Models.Day7.Directory;
using File = AdventOfCode2022.Models.Day7.File;

namespace AdventOfCode2022.Models
{
    /// <summary>
    /// The day 7 model.
    /// </summary>
    internal class Day7Model : BaseModel<int>
    {
        /// <inheritdoc />
        public Day7Model(IList<string> inputLines)
            : base(inputLines)
        {
        }

        /// <inheritdoc />
        public override int CalculatePart1()
        {
            var directory = GetDirectoryStructure();

            return CalculatePart1Helper(directory);
        }

        /// <inheritdoc />
        public override int CalculatePart2()
        {
            var totalSize = 70000000;
            var minimum = 30000000;

            var directory = GetDirectoryStructure();
            var leftSpace = totalSize - directory.Size;
            var toBeDeleted = minimum - leftSpace;

            var possibleDirectories = GetDirectoriesBigEnough(directory, toBeDeleted);

            return possibleDirectories.Min(d => d.Size);
        }

        /// <summary>
        /// The get directory structure.
        /// </summary>
        /// <returns>
        /// The <see cref="Directory"/>.
        /// </returns>
        private Directory GetDirectoryStructure()
        {
            var root = new Directory();

            var currentDirectory = root;
            foreach (var line in InputLines)
            {
                var content = line.Split(' ');
                if (line.StartsWith("$"))
                {
                    // Execute command
                    var command = content[1];
                    if (command == "cd")
                    {
                        var newFolder = content[2];
                        if (newFolder == "/")
                        {
                            currentDirectory = root;
                        }
                        else if (newFolder == "..")
                        {
                            currentDirectory = currentDirectory.Parent ?? root;
                        }
                        else
                        {
                            var directory = currentDirectory.Directories.FirstOrDefault(x => x.Name == newFolder);
                            currentDirectory = directory ?? root;
                        }
                    }
                } 
                else if (line.StartsWith("dir"))
                {
                    // Found a directory
                    var directory = new Directory { Name = content[1], Parent = currentDirectory };
                    currentDirectory.Directories.Add(directory);
                }
                else
                {
                    // Line is a file
                    var file = new File { Name = content[1], Size = int.Parse(content[0]) };
                    currentDirectory.Files.Add(file);
                }
            }

            return root;
        }

        /// <summary>
        /// The calculate part 1 helper.
        /// </summary>
        /// <param name="directory">
        /// The directory.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        private int CalculatePart1Helper(Directory directory)
        {
            var sum = 0;
            if (directory.Size <= 100000)
            {
                sum += directory.Size;
            }

            foreach (var childDirectory in directory.Directories)
            {
                sum += CalculatePart1Helper(childDirectory);
            }

            return sum;
        }

        /// <summary>
        /// The get directories big enough.
        /// </summary>
        /// <param name="directory">
        /// The directory.
        /// </param>
        /// <param name="minimumSize">
        /// The minimum size.
        /// </param>
        /// <returns>
        /// The <see cref="IList"/>.
        /// </returns>
        private IList<Directory> GetDirectoriesBigEnough(Directory directory, int minimumSize)
        {
            var directories = new List<Directory>();
            if (directory.Size >= minimumSize)
            {
                directories.Add(directory);
            }

            foreach (var childDirectory in directory.Directories)
            {
                directories.AddRange(GetDirectoriesBigEnough(childDirectory, minimumSize));
            }

            return directories;
        }
    }
}