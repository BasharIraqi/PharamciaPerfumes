The project is about online perfumes shop managment, in this shop customers can access to make online orders or delete the order or update there order or see what a specific order
that they made.
On the other side we have managers that can see to every customer orders with all information but cant access to orders for security reasons the only one that can access to all
things is the director how can do anything.
In the solution i make three project one for UI ,second for Entities that have all the classes and the interface , three a diffrent project for the users.
In PharamaciaEntities i have four classes Employees,Customers,Orders,Products.
In PharamaciaPerfumesUI i Have the models that  have the dbcontext and i have migaration folder with all migaration and user control folder with all three users control one for 
customers that can add or delete or update or show order, the second for employees that we have two access types on for manager and the second for director,manager can see
specifec customer order and cant access to orders to add,delete,update,show like director.
in every add or delete or update or show or user access we connect to a sql database that call Pharamacia Perfumes and in every connect we update what realative.
in the database we have five tables one for the migaration that save every migaration we did, second for employees,third for orders,fourth for users,fifth for products.
