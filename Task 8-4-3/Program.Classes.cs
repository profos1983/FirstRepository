using System.Text.Json;

partial class Program
{
    const string serializeFile = "Contact.json";
    const string serializeFileInBinary = "Contact.bin";
    /// <summary>
    /// Класс для проверки серализации
    /// </summary>
    [Serializable]
    public class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Contact( string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public void PrintContact ()
        {
            Console.WriteLine($"ФИО:        {this.Name}\nтелефон:    {this.PhoneNumber}\nE-mail:     {this.Email}");
        }
    }

    //Метод сарализации класса через Json
    public static void SerializeContact(Contact contact)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        var jsonString = JsonSerializer.Serialize(contact, options);
        File.WriteAllText(serializeFile, jsonString);
        Console.WriteLine("Объект" + contact.ToString() + " сериализован");
    }

    // Метод для десериализации класса через Json
    public static void DeserializeContact()
    {
        var jsonString = File.ReadAllText(serializeFile);
        var newContact = JsonSerializer.Deserialize<Contact>(jsonString);
        Console.WriteLine("Объект десериализован");
        Console.WriteLine($"Имя: {newContact.Name} --- Телефон: {newContact.PhoneNumber} --- Почта: {newContact.Email}");
        Console.ReadLine();
    }

    //Доработайте класс Contact и сериализуйте в бинарный формат.

    // Серилизация в бинарном формате класса Contact
    public static void SerelazeContactInBinary( Contact contact)
    {
        string InstanceName = nameof(contact);
        using (BinaryWriter bw = new BinaryWriter(File.Open(serializeFileInBinary, FileMode.OpenOrCreate)))
        {
            bw.Write(contact.Name);
            bw.Write(contact.PhoneNumber);
            bw.Write(contact.Email);
            Console.WriteLine("Серилизация в бинарном формате завершена.");
        }
    }

    //Десерелизация в бинарном формате
    public static Contact DeserelazeContactInBinary()
    {
        if (File.Exists(serializeFileInBinary))
        {
            using (BinaryReader br = new BinaryReader(File.Open(serializeFileInBinary, FileMode.Open)))
            {
                string name = br.ReadString();
                string phoneNumber = br.ReadString();
                string email = br.ReadString();

                Console.WriteLine("Произведена десерелизация класса.");
                return new Contact(name, phoneNumber, email);
                
            }
        }
        else
        {
            Console.WriteLine("Файл не существует, будет возвращен пустой экземплят класса Contract!");
            return new Contact(null, null, null);
        }
    }

}