public class UserService
{
    public async Task AddCustomClaimToUser(string userId)
    {
        // Initialize the FirebaseApp using the Firebase configuration values
        FirebaseApp.Create(new AppOptions
        {
            Credential = GoogleCredential.GetApplicationDefault(),
            ProjectId = projectId
        });

        // Get the Firebase user by user ID
        var user = await FirebaseAuth.DefaultInstance.GetUserAsync(userId);

        // Add the custom claim to the user
        var claims = new Dictionary<string, object>
        {
            { "admin", true } // Add your custom claim here
        };

        await FirebaseAuth.DefaultInstance.SetCustomUserClaimsAsync(user.Uid, claims);
    }
}





