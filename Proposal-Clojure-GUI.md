## GUI in Clojure

### Why?
1. Clojure is just as portable as Java, as it is built on the JVM.
2. Clojure provides wrapper libraries to make things that are ugly in Java pleasant, like Java Swing with the [seesaw](https://github.com/daveray/seesaw) library.
3. Also has integration with latex through the [Incanter](http://data-sorcery.org/2010/04/14/latex/) library or through the [Gorilla REPL](http://gorilla-repl.org/start.html). [Go here](https://gist.github.com/liebke/2f99f799e11c98a33ec9) to see how easy it is to add such things in Clojure with Incanter.
4. Using Clojure doesn't mean we can't use Java. All Java classes can be imported into Clojure and with a bit of work, Clojure functions can be imported into Java programs. And Clojure can be compiled to .jar executables if required.


### Why not?
1. The interface to the C server might be interesting but it would of been the same for Java.
2. Any other reasons?

