select ContactTypeID,Name
from
Person.ContactType C 
where Name Like '%Manager' order by ContactTypeID desc;

