namespace UniqueEmailAddresses;

public class Solution {

    public int NumUniqueEmails(string[] emailAddresses) {

        var uniqueEmails = new HashSet<string>();

        foreach (var email in emailAddresses) {
            uniqueEmails.Add(GetFormattedEmail(email));
        }

        return uniqueEmails.Count;
    }

    private string GetFormattedEmail(string email) {
        
        var emailParts = email.Split("@");
        var local = emailParts[0].Split("+")[0];
        local = local.Replace(".", "");
        var domain = emailParts[1];

        return $"{local}@{domain}";
    }
}
