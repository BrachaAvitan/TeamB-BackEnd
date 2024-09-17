CREATE TABLE Books (
    BooksID INT IDENTITY(1,1) PRIMARY KEY,
    Author NVARCHAR(MAX) NOT NULL,
    Title NVARCHAR(MAX) NOT NULL,
    PublishYear INT NOT NULL,
    Price DECIMAL(18, 0) NOT NULL
);
INSERT INTO Books (Author, Title, PublishYear, Price)
VALUES
('Rivka Miriam', 'The Good Life', 2018, 45.00),
('Avraham Cohen', 'The Story of Jerusalem', 2020, 55.00),
('Batya Bernstein', 'A Higher Love', 2017, 50.00),
('Yehoshua Hartman', 'Light in the Valley', 2019, 60.00),
('Chaya Neyman', 'Finding the Way', 2021, 65.00),
('Menahem Mendel', 'Beacon of Hope', 2016, 40.00),
('Hadassah Yaari', 'Steps of Life', 2022, 70.00),
('Shlomo Zalman', 'The Secret of the Valley', 2015, 45.00),
('Sima Berlin', 'Lights in the Home', 2023, 75.00),
('Efrat Elias', 'The Closed Circle', 2024, 80.00),
('Tzipora Abramovich', 'Paths of Light', 2019, 50.00),
('Nachman Goldberg', 'The Great Gift', 2021, 60.00),
('Sara Levi', 'Blue Eyes', 2018, 55.00),
('Meir Fischer', 'The Lips Will Speak', 2017, 45.00),
('Yehudit Kaplan', 'Heat and Light', 2022, 70.00);
select * from[dbo].[Books]