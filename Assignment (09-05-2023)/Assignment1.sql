insert into Person.BusinessEntity (ModifiedDate) values (GETDATE());
insert into Person.BusinessEntity (ModifiedDate) values (GETDATE());
insert into Person.BusinessEntity (ModifiedDate) values (GETDATE());
insert into Person.BusinessEntity (ModifiedDate) values (GETDATE());
select * from Person.BusinessEntity order by BusinessEntityID desc;


insert into Person.Person ( [BusinessEntityID]
      ,[PersonType]
      ,[NameStyle]
      ,[Title]
      ,[FirstName]
      ,[MiddleName]
      ,[LastName]
      ,[Suffix]
      ,[EmailPromotion]
      ) values
	  (20778,'EM',0,'Mr.','Siva','kumar','k','PhD',1),
	  (20779,'EM',0,'Mr.','Vijay','kumar','k','PhD',1),
	  (20780,'EM',0,'Mr.','Visnu','kumar','k','PhD',1),
	  (20781,'EM',0,'Mr.','Manoj','kumar','k','PhD',1);


select * from Person.Person order by BusinessEntityID desc;