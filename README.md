### Thank you
Aviv, first of all would like to thank you for giving me this opportunity to work on something out of the box for me. It was a bit difficult at the beginning to grasp the requirements but afterwards I got into the subject and implemented partially some of the requirements. Anyways I think today I have remembered some things about loggers :)

### Status
I briefly tested Console, File, Rolling File scenarios. They should be functional. Didn't have any time to implement TCP scenario unfortunately.

### What I didn't manage to do in time
- Finish the TCP flow and test carefully all the scenarios
- The code is now inside a Console Application. It should have been a Class Library instead.
- JsonConverter needs to be written more generic, currently it has the file name injected in the constructor. Proper error handling.
- Validation for config file. We have none at the moment. Also the config file can be organized better but I wanted to just stick to the written requirements and not make assumptions.
- Decouple all dependencies to .NET static classes - create wrappers for them and inject them so we can write proper unit tests.
- Have a Stream File wrapper to have it reusable
- Create test project and write unit tests
- Make better use of Factory to resolve Logger and Appenders - currently this is done in some manually created Factory classes. At least for Appenders I could have used the Castle.Windsor possibility to resolve a component using a Prefix for the name. But for logger also I think it couldn't have been done better.
- And probably more but I think it's enough for now.

Cheers,
Ovidiu