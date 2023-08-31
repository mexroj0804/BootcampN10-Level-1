//ChatMessage modelidan foydalaning ( unique Id, SentTime, EditedTime, Content )
//unda quyidagi konstruktorlar bo'lsin
//- parameterized ( content ) -konstruktorda Id, SentTime va Content ga qiymat berilsin
//- copy ( chatMessage ) -chatMessage objectidagi barcha qiymatlarni o'ziga o'zlashtirsin, EditedDate ga hozirgi vaqt qo'yilsin

//Chat servicedan foydalaning 
//unda quyidagi propertylar bo'lsin
//- Messages - ChatMessage tipidagi kolleksiya

//unda quyidagi methodlar bo'lsin 
//- Add ( content ) -content valid ekanligini tekshirib, ChatMessage dan object yaratib, kolleksiyaga qo'shilsin - invalid bo'lsa - exception
//- Update ( id, content ) -kolleksiyadan Id bo'yicha topib, contentni validate qilib, topilgan message dan copy olinsin, content update qilinib, kolleksiyaga qo'shilsin, topilmasa - exception
//- Display - messagelarni jo'natilgan ketma ketligi bo'yicha ekranga chiqarsin, bunda agar bitta message dan bir nechtasi bolsa - ya'ni edit qilingan bo'lsa, oxirgi edit qilingan versiyasi chiqsin

//MessageValidator static servicedan foydaning 
//unda quyidagi methodlar bo'lsin
//- IsValidMessage ( content ) -xabar valid ekanligini tekshirsin


public class ChatMessage
{
    public Guid Id { get; set; }
    public DateTime SentTime { get; set; }
    public DateTime EditTime { get; set; }
    public string Content { get; set; }

    public ChatMessage(string content)
    {
        Content = content;
        Id = Guid.NewGuid();
        SentTime = DateTime.Now;
    }

    public void Copy(ChatMessage chat)
    {
        Content = chat.Content;
        Id = chat.Id;
        SentTime = chat.SentTime;
        EditTime = DateTime.Now;
    }
}

public class Chat
{
    List<ChatMessage> Messages = new List<ChatMessage>();

    public Guid Add(string content)
    {
        if (MessageValidator.IsValidMessage(content))
        {
            var message = new ChatMessage(content);
            Messages.Add(message);
            return message.Id;
        }
        else
        {
            throw new Exception("Invalid content!");
        }
    }

    public void Update (Guid id, string content)
    {
        foreach (var item in Messages)
        {
            if (item.Id == id)
            {
                if (MessageValidator.IsValidMessage(content))
                {
                    var copy = new ChatMessage(content);
                    Messages.Remove(copy);
                    copy.Content = content;
                    Messages.Add(copy);
                    return;
                }

            }
            else
            {
                throw new Exception("Invalid message!");
            }
        }
    }

    public void Display()
    {
        foreach(var item in Messages)
        {
            Console.WriteLine($"{item.Content} - {item.SentTime}");
        }
    }
}

public static class MessageValidator
{
    public static bool IsValidMessage(string content)
    {
        if (!string.IsNullOrEmpty(content) && !string.IsNullOrWhiteSpace(content))
        {
            return true;
        }
        else
        {
            throw new Exception("Invalid message!");
        }
    }
}