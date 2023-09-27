# Person-Management-BackEnd
Person Management Project User Interface
Admin Account:
Username: tjones
Password: Admin123

Standard Account:

Username: athomas
Password: Standard123

Scripts to insert user accounts:

USE [PersonManagement]
GO

INSERT INTO [dbo].[PM03_User]
           ([Name]
           ,[Surname]
           ,[Username]
           ,[Email]
           ,[Role]
           ,[Password])
     VALUES
           ('Tom'
           ,'Jones'
           ,'tjones'
           ,'tjones@email.com'
           ,'Admin'
           ,'E64B78FC3BC91BCBC7DC232BA8EC59E0'), -- hashed password
		   (
		   'Andy'
           ,'Thomas'
           ,'athomas'
           ,'athomas@email.com'
           ,'Standard'
           ,'82B278BEEC33B3C27DEF7283DF580374'
		   )
GO


Scripts to insert people's data (marital status):

USE [PersonManagement]
GO

INSERT INTO [dbo].[PM02_MaritalStatus]
           ([MaritalStatus]
           ,[isActive])
     VALUES
           ('I/E Martuar'
           ,1),
		   ('I/E Ndare'
           ,1),
		   ('I/E Ve'
           ,1),
		   ('Beqar/e'
           ,1)
GO

Scripts to insert people's data:

USE [PersonManagement]
GO

INSERT INTO [dbo].[PM01_Person]
           ([Name]
           ,[Surname]
           ,[DateofBirth]
           ,[Phone]
           ,[Gender]
           ,[IsEmployed]
           ,[Id_maritalstatus]
           ,[PlaceofBirth])
     VALUES
           ('Armando'
           ,'Ferrero'
           ,'1999-03-02 00:00:00.000'
           ,658525456
           ,'M'
           ,1
           ,1
           ,'Tirane'),
		        ('Kejdi'
           ,'Hoxha'
           ,'2002-06-23 00:00:00.000'
           ,653224123
           ,'M'
           ,1
           ,4
           ,'Kavaje'),
		        ('Shaqir'
           ,'Sulaj'
           ,'2001-09-24 00:00:00.000'
           ,433534354
           ,'M'
           ,1
           ,4
           ,'Burrel'),
		        ('James'
           ,'Bond'
           ,'2023-09-24 00:00:00.000'
           ,5464564
           ,'M'
           ,0
           ,3
           ,'Tirane')
GO

