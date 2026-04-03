\## Minimal reproducible example of blazor "if statement" bug



This repository is a a minimal demonstration of a bug I encountered where blazor will render components inside of an "if" statement even though the if statement is false.



Clicking the button on the home page will cause a crash inside of ChildComponent, due to Foo.Child being null, but the component should be protected by an if statement that checks that Foo.Child is non null.

