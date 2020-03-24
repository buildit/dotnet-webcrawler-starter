Please, note that you have 5 days to complete the exercise from the day it has been sent out.



Here are the instructions for the Buildit - Wipro Digital Platform Engineer - Cloud exercise :

## What we are looking for
There are no tricks or hidden agendas. The purpose of this exercise is for you to demonstrate your technical knowledge, reasoning, and engineering practices using current software development technologies and methods. Please make sure your code is clear and demonstrates your best practices. The exercise should be done as if you were building software to hand off to someone else.  Refrain from using this as an opportunity to learn a new framework, library or paradigm besides what you feel would be essential to completing this task.

Your solution will form the basis for discussion in subsequent interviews.

## What you need to do
Please write a simple web crawler in C#.

The crawler should be limited to one domain. Given a starting URL – say http://wiprodigital.com - it should visit all pages within the domain, but not follow the links to external sites such as Google or Twitter.

The expected output format:
```json
{
    "uri": "https://test.com/about.html",
    "internalLinks": [
        "https://test.com/",
        "https://test.com/about.html#",
        "https://test.com/search.html",
        "https://test.com/categories.html",
        "https://test.com/articles/2015-04-23-forum/",
        "https://test.com/feed.xml"
    ],
    "externalLinks": [
        "https://groups.google.com/forum/#!forum/test",
        "https://test.tumblr.com/",
        "https://www.agilementoring.com/",
        "mailto:test@test.com",
        "https://github.com/test",
        "https://twitter.com/test"
    ],
    "images": [
        "/assets/test.svg"
    ]
}
```

Please update this README.md describing your thought process and the tradeoffs made. Also, detail anything further that you would like to achieve with more time.

Once done, please make your solution available on Github and forward the link. Where possible please include your commit history to provide visibility of your thinking and working practice.

## What you need to share with us
* A working crawler as per requirements above
* An updated README.md explaining:
* Reasoning and describe any trade offs
* Explanation of what could be done with more time
* Project builds / runs / tests as per instruction

Good luck and thank you for your time - we look forward to seeing your creation.

## Running the app
1. Test the endpoint with `curl http://localhost:8080/crawl?url=<-- url to be crawled>`
