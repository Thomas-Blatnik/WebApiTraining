# What is a service?

It is some code that owns some process for the company.
- that pcess also probably needs some data (state)
    - state is data + now
    - (this is parat of the explanation of why we say "Microservices don't share databases")
- It is a processs that has to be running, or be able to be started to do it's work.


# What is an API?
    - "Application Programmin Interface"
    - Contrasted with a User Interface (UI)
    - An interface is meant to allow the user to accomplish something we want them to accomplish.
    - We want them to be able to accomplish it as easily as possible, with the minimum amount of errors.
    - Don't design APIs to be like batch processes, or order forms, or whatever

# What is a "Web API"
- An API that is based on the HTTP Application Layer Protocol
- RFC 2616
- Sir Tim Berners Lee - created WWW
- Roy Fielding saw this as a great way for two applications to talk to each other.

# Http Has the "Consistent Interface Constraint"
- Resource Oriented Architecture (not "object oriented", "functional", service oriented, etc.)
    - Resources art the important things we want available through our API. They are "concepts"
        - They are identified by a URI.
        - They are nouns. Not verbs. The nouns are usually singular or plural.
        - Singular resources are "documents"
        - Plural resources are "collections"
        - https://api.company.com/employees
            - collection.
        - https://api.company.com/employees/bob-smith
            - document. There is ONE employee named bob smith
            - often (but not always) a subordinate resource of a collection.
            - https://api.company.com/employees/bob-smith/day-off-requests
            - GET https://api.some-insurance-company.com/policies/{policynumber}/vehicles
            - Steve Klabnik - "Add a new resource"
- It has constraints (limitations) BAKED IN - like request-response, stateless, intermediaries, etc.
- Synchronous request/response. A -> B

# Issue Tracker for BSD

```http
POST /issues
Content-Type: application/json

{
    "user": "Bob@aol.com",
    "software": "Excel",
    "description": "It doesn't work"
}

```