# OnePageMore

### Overview
When it comes to elementary school, reading is a large part of the curriculum. With my own children, I have found that making reading part of our day has helped with comprehension. I would love to say that this was an easy addition to our day, but reading time can easily be pushed aside for tasks that seem more important such as accompanying me to the grocery store, cleaning a bedroom, or even rushing through bedtime. Building this habit is just as much my job as theirs.  Not sure about your children, but anything on a screen makes it that much cooler, so hopefully this format can help build those habits.

The purpose of this website is to create a record of reading that can be used within the family or shared with teachers. While a book API could easily be imported, at this stage I want as few distractions for my kids as possible. Book information is collected from user input. Inital input will collect data including title, author name, and number of pages.  Book data will be presented on one of two tables based on reading progress:  "Currently Reading" and "Completed Reads".  Books will be moved between tables based on the page numbers.  

There will be two views:  A Parent view and Child view.  The child will have the ability to add books and update page numbers.  A parent will have the ability to edit book data (incase of typos or page number errors) and delete books after a certain date.  The parent may also have the ability to email the tables to their child's teacher to document reading and reading progress.

### Plans
This will be built using ASP.NET Core using EF Framework and mySQL.  Currently this is an MVC build with CRUD capacity.  Authorization and Authentication will be added to verify child and parent capabilities and correct usage (don't want the 5 year-old deleting all the books or emailing their kindergarten teacher 3 million times).
