# LockerStorage - Storage Allocation System

The system was developed as an assignment for Application Programming With Visual Basic .NET module of my Higher Diploma. Microsoft Access was used as a database for this project. The information below is courtesy of TMC Academy, Singapore, and it is a detailed description of the system and functions implemented.

### Background
(copyright TMC Academy – School of IT, Digital Media & Mass Comm, April 2015):

> The company is currently undergoing a restructuring process as part of its strategic move. A
> proposal was to have a storage allocation system situated in the downtown branch where
> shoppers can use the self-storage facility to store and retrieve items on their own.
> To better facilitate the allocation of the storage space, the management has decided to
> implement a computerised self-service storage allocation system with a user-friendly interface
> for the usage of the storage facility.
> 
> There will be four categories of storage spaces of varying sizes and rental rates. There are a
> total of 30 lots (storage spaces) available. Each lot has a unique Lot number, Lot category, Lot
> size hourly rental rate, Lot location, and availability status of the individual Lot.
> The storage allocation system should allow users to choose a Lot that is available, input the
> duration of the rental in hours, record the users’ particulars and calculate the total rental amount
> with additional fees added (if any).
> 
> The storage allocation system should also allow LockerStorage’s employees to manage the
> Lots’ details as well as the rental records and generate daily rental reports.
> As an application developer, you have been approached by the warehouse supervisor to create
> a prototype Storage Allocation System. Presently, all assigned tasks will only implement the
> basic requirements. These tasks may be further extended in the coursework.

### Database interactions:
(copyright TMC Academy – School of IT, Digital Media & Mass Comm, April 2015)
- The supervisor is given the rights to create accounts and administer the accounts of the other employees.
- Each employee will log-in to the application using a given username and password.
- The employees are expected to enter the correct username and password before they can use the system.
- Upon successfully logging in, the New Lot Interface will be displayed.
- An interface that will be used by the supervisor to create and administer the accounts of other employees is implemented.
- The login interface is adapted so that the correct usernames and passwords entered by the supervisor are required to log in.

### Storage Space Data Management
(copyright TMC Academy – School of IT, Digital Media & Mass Comm, April 2015)

- The employees will perform data entry for new Lots (storage space) added.
- Also, they have the rights to manage the Lot’s data including updating of Lot’s details and deleting of inactive Lots.
- An interface which captures the following details is implemented: Lot number, Lot category, Lot size, hourly rental rate, Lot location, availability status of the  individual Lot, any other appropriate details for the new Lots and stores these details in the database.

### Rental Data Management
(copyright TMC Academy – School of IT, Digital Media & Mass Comm, April 2015)

- Any user is able to perform rental transaction using the storage allocation system.
- The user needs to choose a Lot that is available, input the duration of the rental (in hours), input their particulars (Name, NRIC/Passport number, home address, contact number, date of birth, and email) and choose the payment method (cash or credit card).
- Payment by credit card will incur an additional fee of $3 per transaction.
- The system will then calculate the total rental amount with any additional fees added and display appropriate information before they are stored into the database. 
- An interface which captures the rental transaction information as stated above and stores this in the database is implemented.
- Additionally, the interface allows employees to edit the rental records when necessary.

### Report Generation
(copyright TMC Academy – School of IT, Digital Media & Mass Comm, April 2015)

- The supervisor is able to generate daily rental report for any required day.
- The report contains the rental details, user’s details, Lot’s details should be sorted in ascending order of Lot number and grouped by Lot category.
