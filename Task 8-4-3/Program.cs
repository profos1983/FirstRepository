Contact contact1 = new( "Алексей Миронов", "8-905-1643819", "alexiss@mail123.ru");

//SerializeContact(contact1);
//DeserializeContact();

SerelazeContactInBinary(contact1);

Contact contact2 = DeserelazeContactInBinary();
contact2.PrintContact();