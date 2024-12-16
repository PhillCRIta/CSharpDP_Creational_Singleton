### Please note before start reading
Those code examples about design pattern have the purpose of personal use, to easily remember the patters; it's like a notepad. I took the following examples from Youtube and some web articles.

The major source of the examples is a Youtube channel of [DoableDanny](https://www.youtube.com/@doabledanny/videos), he's a very good developer. I suggest to all to buy 📒his book about design pattern 📒 , it's very clear.

# Singleton patter
Singleton pattern is used for provide a uniqueand global point of access to a instance. \
In the example case we instantiate a only oneclass to connect to database and reuse thatclass many times as needed.\
The singleton pattern ensure that the data saved into it remain the same in all app. \
Inside a singleton class there are a static instance of itself, a static member can be used as a Global member of the application because it allocated at the beginning of the program; it's instantiate once in all program.\
There are many useful articles about memory usage for static member of class, or class:
- https://medium.com/c-programming/c-memory-management-part-1-c03741c24e4b
- https://www.linkedin.com/posts/mha-karimi_dotnet-dotnetdeveloper-dotnetcore-activity-7174056690701471746-5sKu
- https://www.c-sharpcorner.com/article/working-with-static-in-c-sharp/
- https://medium.com/@javvadirupasri8/demystifying-static-in-c-understanding-how-it-works-d7b47a1acb32
  
and a very good article on stackoverflow:
- https://stackoverflow.com/questions/35705878/local-variable-vs-static-variable-memory-and-performance
