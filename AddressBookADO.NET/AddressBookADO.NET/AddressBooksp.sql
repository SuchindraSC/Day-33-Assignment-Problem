SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SpAddPersonDetails]
(
@firstName varchar(255),
@lastName varchar(255),
@address varchar(255),
@phoneNumber varchar(255),
@zip int,
@city varchar(255),
@state varchar(255),
@emailId varchar(255),
@addressBookName varchar(255),
@type varchar(255)
)
as
begin
insert into AddressBook values
(
@firstName,@lastName,@address,@city,@state,@zip,@phoneNumber,@emailId,@addressBookName,@type
)
end
GO
