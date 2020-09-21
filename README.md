# OnePageMore

### Overview
When it comes to elementary school, reading is a large part of the curriculum. With my own children, I have found that making reading part of our day has helped with comprehension.  The reading itself was an easy addition to add to our day, but the documentation of it was the hardest part for me to remember.  The worksheets sent home from the teacher didn't always make it home some days, or would dissapear on the fridge among all the other papers and artwork.  The habit of reading has been well established, but documentation is where we all fell short.  Hopefully, an app like this would make it easier overall to record our reading progress and let their teachers know we are doing our reading homework, even if we don't return the paper.  And, not sure about your children, but my children love any chance to work on a screen so this will make it more fun for them too.

The purpose of this website is to create a record of reading that can be used within the family or shared with teachers. While a book API could easily be imported, at this stage I want as few distractions for my kids as possible. Book information is collected from user input. Inital input will collect data including title, author name, and number of pages.  Book data will be presented on one of two tables based on reading progress:  "Currently Reading" and "Completed Reads".  Books will be moved between tables based on the page numbers.  

There will be two views:  A Parent view and Child view.  The child will have the ability to add books and update page numbers.  A parent will have the ability to edit book data (incase of typos or page number errors) and delete books after a certain date.  The parent may also have the ability to email the tables to their child's teacher to document reading and reading progress.

### Plans
This will be built using ASP.NET Core using EF Framework and mySQL.  Currently this is an MVC build with CRUD capacity.  Authorization and Authentication will be added to verify child and parent capabilities and correct usage (don't want the 5 year-old deleting all the books or emailing their kindergarten teacher 3 million times).
