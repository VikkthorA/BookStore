## Setup & Configuration (Important!)
### Features requiring configuration:
* **Database Connection:** You need to set up a local MySQL database and provide your own credentials.
* **Stripe Payment Gateway:** Required to test the shopping cart checkout process.
* **Facebook Authentication:** Required to test the "Log in with Facebook" feature.

Admin Access (Testing & Review)
*This project includes an automated database initializer (`DbInitializer`). When you run the application for the first time, it applies any pending migrations and automatically seeds the necessary user roles along with a default Admin account.
*You can use the following credentials to log in and explore the **Admin Panel** (which allows you to manage products, categories, orders, and more):

* **Email:** `admin@dotnetmastery.com`
* **Password:** `Admin123*`
