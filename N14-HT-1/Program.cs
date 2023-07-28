using System.Collections.Generic;
using System.ComponentModel;

NotificationMessages dastur = new NotificationMessages();
dastur.SearchMessage("Blocked");
public class NotificationMessages
{
    public NotificationMessages()
    {
        dict.Add("SuccRegistration", "You successfully registered");
        dict.Add("AskPassword", "Enter your password");
        dict.Add("Blocked", "Your account has been blocked");
    }
    private Dictionary<string, string> dict = new Dictionary<string, string>();
    
    protected void FindMessage(string nameMessage)
    {
        foreach(KeyValuePair<string, string> pair in dict)
        {
            if(pair.Key == nameMessage) 
            {
                Console.WriteLine(pair);
            }
        }
    }
    public void SearchMessage(string Message)
    {
        FindMessage(Message);
    }
}