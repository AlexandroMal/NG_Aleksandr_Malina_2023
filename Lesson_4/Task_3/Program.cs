using Task_3.Classes;

Owner owner = new Owner();
owner.RenameFile();
owner.DeleteAll();

Administator administator = new Administator();
administator.DeleteFile();

User user = new User();
user.OpenFile();

