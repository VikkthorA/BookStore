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


### 🖼️ Note on Products & Images
Since the application generates a local database upon the first run, the product catalog will initially be empty and no product images will be visible. 
To test the full user experience (including the shopping cart and homepage UI), please log in with the **Admin credentials** provided above, navigate to the Content Management panel, and create a few test products by uploading your own sample images.
