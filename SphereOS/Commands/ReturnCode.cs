﻿namespace SphereOS.Commands
{
    /// <summary>
    /// Describes whether a command executed successfully.
    /// </summary>
    internal enum ReturnCode
    {
        /// <summary>
        /// The command completed successfully.
        /// </summary>
        Success,

        /// <summary>
        /// The command was provided with invalid arguments.
        /// </summary>
        Invalid,

        /// <summary>
        /// The specified file, directory, or device was not found.
        /// </summary>
        NotFound,

        /// <summary>
        /// The command failed.
        /// </summary>
        Failure,

        /// <summary>
        /// The user is unauthorised to execute this command.
        /// </summary>
        Unauthorised,

        /// <summary>
        /// The command was aborted.
        /// </summary>
        Aborted
    }
}
