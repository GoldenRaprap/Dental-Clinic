/*
 * A class to remember user account information.
 * Recives user ID upon login in LogInPage and stores it.
 * Sends user ID to other forms when needed.
 */

namespace Denics
{
    public static class UserAccount
    {
        // Nullable so "no user" can be represented
        private static int? _userId;

        // Set the current logged-in user
        public static void SetUserId(int userId) => _userId = userId;

        // Returns nullable id (null = no user)
        public static int? GetUserId() => _userId;

        // Convenience: get id or 0 when none
        public static int GetUserIdOrDefault() => _userId ?? 0;

        // Clear the current user (logout)
        public static void Clear() => _userId = null;
    }
}
