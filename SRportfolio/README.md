PORTFOLIO

I have created my PORTFOLIO using dot net framework, which have a navabr with 5 menu items.

Swadhin Rout
Education
Skills
Experience
Hobbies

Types of Routing:-

There are 2 types of Routing in MVC application
(1) Conventional or Traditional Routing (Using Routing Config)
(2) Attribute Routing (Available in MVC 5) 

Conventional or Traditional Routing :-

Conventional or Traditional Routing also is a pattern matching system for URL that maps incoming request to the particular controller and action method.
We set all the routes in the RouteConfig file.
RouteConfig file is available in the App_Start folder.
We need to register all the routes to make them operational.

Attribute Routing :-

It is a very simple routing method compared to conventional routing. 
All the concepts are just like the conventional approach but here, we define all the routes and attributes. 

In attribute, we define the routing on a simple controller or action method. 


Action Filters :-
 
Action Filter is an attribute that you can apply to a controller action or an entire controller. 
This filter will be called before and after the action starts executing and after the action has executed.
 Action filters implement the IActionFilter interface that has two methods OnActionExecuting andOnActionExecuted. 
OnActionExecuting runs before the Action and gives an opportunity to cancel the Action call. 
These filters contain logic that is executed before and after a controller action executes, you can use an action filter, for instance, to modify the view data that a controller action returns.


The four main HTTP methods (GET, PUT, POST, and DELETE)

GET retrieves the representation of the resource at a specified URI. ...
PUT updates a resource at a specified URI. 
POST creates a new resource. 
DELETE deletes a resource at a specified URI.
PATCH Partial updates

Collection:- It's a framework for Array.