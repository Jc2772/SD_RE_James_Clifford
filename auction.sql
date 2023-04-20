DROP TABLE Sales;
DROP TABLE bookings;
DROP TABLE auctions;
DROP TABLE Livestock;
DROP TABLE Owners;

CREATE TABLE Owners(
OwnerId NUMERIC(3) NOT NULL,
ForeName VARCHAR2(20) NOT NULL,
SurName VARCHAR2(20) NOT NULL,
Area VARCHAR2(15) NOT NULL,
Town VARCHAR2(15) NOT NULL,
County VARCHAR2(10) NOT NULL,
PhoneNo CHAR(10) NOT NULL,
Email VARCHAR2(30),
owner_status CHAR(1) DEFAULT 'R',
CONSTRAINT PK_OwnerId PRIMARY KEY (OwnerId)
);
CREATE TABLE Livestock(
TagNo CHAR(15) NOT NULL,
OwnerId NUMERIC(3) NOT NULL,
LivestockType VARCHAR2(6) NOT NULL,
Breed VARCHAR2(20) NOT NULL,
Age NUMERIC(2) NOT NULL,
Gender CHAR(1) NOT NULL,
CONSTRAINT PK_TagNo PRIMARY KEY (TagNo),
CONSTRAINT FK_OwnerId FOREIGN KEY (OwnerId) REFERENCES Owners(OwnerId)
);

CREATE TABLE Auctions(
AuctionId numeric(4),
AuctionDate date,
CONSTRAINT PK_Auctions PRIMARY KEY (AuctionId)
);

CREATE TABLE Bookings(
BookingId numeric(5) NOT NULL,
AuctionId,
timeslot CHAR(5) NOT NULL,
OwnerID numeric(3) NOT NULL,
StartingPrice numeric(7,2) NOT NULL,
BookingStatus char(1) default 'U',
TagNo NOT NULL,
CONSTRAINT PK_Bookings PRIMARY KEY(BookingId),
CONSTRAINT FK_BookingsAuctionId FOREIGN KEY (AuctionId) REFERENCES Auctions,
CONSTRAINT FK_BookingsOwners FOREIGN KEY (OwnerId) REFERENCES Owners,
CONSTRAINT Fk_TagNo FOREIGN KEY (TagNo) REFERENCES Livestock
);

CREATE TABLE Sales(
SaleId NUMERIC(5)NOT NULL,
FinalPrice NUMERIC(7,2)NOT NULL,
BookingId,
CONSTRAINT PK_SaleId PRIMARY KEY(SaleId),
CONSTRAINT FK_BookingId FOREIGN KEY (BookingId) REFERENCES Bookings(BookingId)
);