insert into owners(ownerid,forename,surname,area,town,county,phoneno,email)
values(1,'bob','jones','somewhere','idk','where','7775553333','no email specified');

insert into owners(ownerid,forename,surname,area,town,county,phoneno,email)
values(2,'bobby','jon','somewhere','idk','where','9997775555','no email specified');

insert into owners(ownerid,forename,surname,area,town,county,phoneno,email)
values(3,'bobbert','johnson','somewhere','idk','where','8886664444','no email specified');

insert into owners(ownerid,forename,surname,area,town,county,phoneno,email)
values(4,'bill','jobs','somewhere','idk','where','6664442222','no email specified');

insert into owners(ownerid,forename,surname,area,town,county,phoneno,email)
values(5,'bobbo','jim','somewhere','idk','where','5553331111','no email specified');

insert into auctions(auctionid,auctiondate) 
values(1,to_date('2020-1-2','yyyy-mm-dd'));

insert into livestock(tagno,ownerid,livestocktype,breed,age,gender)
values('123456789012345',1,'cattle','Aberdeen Angus',4,'M');

insert into livestock(tagno,ownerid,livestocktype,breed,age,gender)
values('111111111111111',1,'cattle','Jersey',3,'F');

insert into livestock(tagno,ownerid,livestocktype,breed,age,gender)
values('222222222222222',1,'sheep','Suffolk sheep',4,'M');

insert into livestock(tagno,ownerid,livestocktype,breed,age,gender)
values('333333333333333',1,'sheep','Vendéen',3,'F');

insert into livestock(tagno,ownerid,livestocktype,breed,age,gender)
values('444444444444444',1,'goat','Saanen',2,'F');

insert into bookings(bookingid,auctionid,timeslot,ownerid,startingprice,bookingStatus,tagno)
values(1,1,'13:00',1,4000,'S','123456789012345');

insert into bookings(bookingid,auctionid,timeslot,ownerid,startingprice,bookingStatus,tagno)
values(2,2,'13:20',1,6000,'S','111111111111111');

insert into bookings(bookingid,auctionid,timeslot,ownerid,startingprice,bookingStatus,tagno)
values(3,2,'12:40',3,500,'S','222222222222222');

insert into bookings(bookingid,auctionid,timeslot,ownerid,startingprice,bookingStatus,tagno)
values(4,1,'11:00',3,700,'S','333333333333333');

insert into bookings(bookingid,auctionid,timeslot,ownerid,startingprice,bookingStatus,tagno)
values(5,3,'09:40',5,300,'S','444444444444444');

insert into sales(saleid,finalprice,bookingid)
values(1,4500,1);

insert into sales(saleid,finalprice,bookingid)
values(2,900,2);

insert into sales(saleid,finalprice,bookingid)
values(3,900,3);

insert into sales(saleid,finalprice,bookingid)
values(4,900,4);

insert into sales(saleid,finalprice,bookingid)
values(5,900,5);
