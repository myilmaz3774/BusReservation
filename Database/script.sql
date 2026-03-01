CREATE DATABASE BusReservationDB;
GO
USE BusReservationDB;
GO

CREATE TABLE Customers (
    CustomerId INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    PhoneNumber NVARCHAR(15) NOT NULL
);

CREATE TABLE BusTrips (
    TripId INT IDENTITY(1,1) PRIMARY KEY,
    Route NVARCHAR(100) NOT NULL,
    DepartureTime DATETIME NOT NULL,
    Price DECIMAL(10,2) NOT NULL
);

CREATE TABLE Tickets (
    TicketId INT IDENTITY(1,1) PRIMARY KEY,
    CustomerId INT FOREIGN KEY REFERENCES Customers(CustomerId),
    TripId INT FOREIGN KEY REFERENCES BusTrips(TripId),
    SeatNumber INT NOT NULL
);

-- Örnek Veriler (Test için)
INSERT INTO BusTrips (Route, DepartureTime, Price) VALUES ('İstanbul - Ankara', '2026-05-10 10:00', 450.00);
INSERT INTO BusTrips (Route, DepartureTime, Price) VALUES ('İzmir - İstanbul', '2026-05-11 14:00', 600.00);
