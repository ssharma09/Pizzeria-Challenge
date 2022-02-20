The goal of this exercise is to refactor the code and fix existing bugs. Please refactor the code applying best practices.

Hints:
- _Pizzeria_ will have another location in the future (Gold Coast)
- The menu in every pizzeria is a subject of change
- You cannot order pizzas that are not available in the selected location
- We still improve our baking process, so it will change in the future. The baking process will vary depending on pizza type
- The same pizza is prepared in the same way across all the locations. The only difference is the price
- We love built-in quality in our products

Nice-to-have:
- We would like to add pizza toppings to the menu: extra cheese, mayo, olive oil
- Our customers would like to order more than 1 pizza at a time


We appoint you a manager of this project, so feel free to add more features if you like :)

Saloni Sharma - Approach and enhancements
===========================================================================================================================================================================
Thank you for sharing the challenge.
I have refactored the code to define abstract classes Pizzeria stores and Pizza.
The store and respective pizza classes implement the methods which will cater to any location/store based offers or changes or pizza preparation,baking,boxing and cutting updates.

The menu and price class take care of defining the menu rolled out for the locations.The values currently are defined in the class.

Further enhancements to this would be :-
1. To fetch them from a config/json file based on the location as defined in the format below.
The menu and prices can that way be updated from the config not impacting the code base.
Menu.json
[
  {
    "Location": "Brisbane",
    "PizzaName": "Capriciosa",
    "Ingredients": "mushrooms, cheese, ham, mozarella",
    "Price": "20"
  },
]

Toppings.json
[
  {
    "Location": "Brisbane",
    "PizzaName": "mayo",   
    "Price": "1"
  },
]

2. Offer store wide discounts 
Adding a dicountCalculation method in the Pizzeria store class and compute the discounts whihc can be fetched from a config.
Dicounts.json
[
  {
    "Location": "Brisbane",
    "Dicount": "10",       
  },
]
