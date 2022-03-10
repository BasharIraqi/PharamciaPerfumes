# Pharamacia Perfumes Online Project
my project is divided to three pieces one for entities another one for UI and the last for the users, the project about an online store for selling perfumes and make orders for customers.

#### *Pharamacia Perfumes Entities:
there is the models folder that have the customer,employees,product,order classes.
then i have the nigeration folder that include all the migration that i have done.
and also i have interfaces that have gneric repository interface.
the last one is the repsitory folder that have the generic repository that extend from the generic interface.

in this project i work with repository pattern to connect with the data base, I made generic interface that
have all the methods that i need to connect with database to pick up the information that i need.

#### *Pharamacia Perfumes UI:
In this project i made all the user controls that i need, at the begging i use the main form as a loggin page if the username begin with __cus__ and the password is correct the order user control open there i have four option add,delete,update,show order that the customer can see and made.

if the username begin with __man__ and the password is correct the employee user control will open and i have there two buttons one for orders and one for customers but the manager only can see customers and there orders and cannot do anything with orders.

At the end i have the big user that begin with __dir__ for the director the big boss on the store and if the password is correct the employee user control will open and the director have two options orders and customers, in customer user control i have grid view of all the customers and i can select specific customer by his id and then i can choose specific order from his orders then i can choose specific order by her id and will show the order products.

The last user control that i have is the sign up user control that if i have new users and i want to add to the database to add one the user name must begin with __cus__ and then some numbers in the password you can choose any thing, and to add manager the user name must begin with __man__ and some numbers if it all correct and the user does not exist in the databse it will be added succesfully.

#### *Users:
In this project i have the user class and interface for checking users accessbility that if the user name begin with __cus__ it is customer and if begin with __man__ it is a manager and if the username begin with __dir__ it is for the director the big user in the project.
