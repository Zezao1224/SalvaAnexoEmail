using System.Net.Mail;
using MailKit.Net.Pop3;
using MailKit;
using MimeKit;


//Servidor de entrada de e-mails (POP)

//Servidor: pop.mail.yahoo.com
//Porta: 995
//Requer SSL: SimServidor de entrada de e-mails (POP)

//Servidor: pop.mail.yahoo.com
//Porta: 995
//Requer SSL: Sim
Console.WriteLine("Hello, World!");
using (Pop3Client client = new Pop3Client())
{

    client.Connect("pop.mail.yahoo.com", 995);
    int messageCount = client.GetMessageCount();
    List<MimeMessage> allMessages = new List<MimeMessage>(messageCount);

    for (int i = messageCount-1; i > 0; i--)
    {
        if (client.GetMessage(i).Attachments.Any())
        {
            allMessages.Add(client.GetMessage(i));
             Message message = client.GetMessage(i); 
            MessagePart messagePart = message.MessagePart.MessageParts[1];
            client.GetMessage(i).Body.ToString();
            client.GetMessage(i).Attachments.FirstOrDefault();
        }
    }
    foreach (MimeMessage msg in allMessages)
    {

        //var att = MimePart.Load(msg);
        //att.save(new System.IO.FileInfo(System.IO.Path.Combine("c:\\xlsx", ado.FileName)));
    }
    //for (int i = 0; i < client.Count; i++)
    //{
    //    MimeMessage message = client.GetMessage(i);
    //    Console.WriteLine("Titulo: {0} ,Dt: {1}, anexo: {3}", message.Subject, 
    //                                                          message.Date, 
    //                                                          message.Attachments. );

    //}

    client.Disconnect(true);
}



    Console.ReadLine();