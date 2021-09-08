SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SpAddPersonDetails]
(
@FirstName varchar(255),
@LastName varchar(255),
@Address varchar(255),
@PhoneNumber varchar(255),
@zip int,
@City varchar(255),
@State varchar(255),
@Email varchar(255),
@AddressBookName varchar(255),
@Type varchar(255)
)
as
begin
insert into AddressBook values
(
@FirstName,@LastName,@Address,@City,@State,@zip,@PhoneNumber,@Email,@AddressBookName,@Type
)
end
GO
