using System.Net;
using System.Net.Mail;
using OpenPop.Mime;
using OpenPop.Pop3;

using (Pop3Client client = new Pop3Client())
{
    client.Connect("pop.mail.yahoo.com", 995, true);
    client.Authenticate("user", "senha", AuthenticationMethod.UsernameAndPassword);
    int messageCount = client.GetMessageCount();
    List<Message> allMessages = new List<Message>(messageCount);
    //Verifica se os 10 últimos e-mails possuem anexo.
    for (int i = messageCount - 10; i > 0; i--)
    {
        if (client.GetMessage(i).FindAllAttachments().Count > 0)
        {
            allMessages.Add(client.GetMessage(i));
        }
    }
    foreach (Message msg in allMessages)
    {
        List<MessagePart> ats = msg.FindAllAttachments();
        foreach (MessagePart at in ats)
        {
            string fileName = at.FileName;
            string finalPath = Path.Combine("E:\\temp", fileName);
            File.WriteAllBytes(finalPath, at.Body);
        }

    }
    client.Disconnect();
}


