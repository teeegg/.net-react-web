
# EB Games Australia Developer Exercise

In this solution there is a small .NET 5 ASP .NET Core application.

There is currently a small issue in the application preventing it from compiling, the first step is to identify the issue and fix the compilation error.

After the application successfully compiles again, please complete the following exercises outlined below.
1. IOC Exercise
2. Reporting Exercise
<br/><br/>

Finally, please create a web front end (using whatever framework/stack you like) to consume the results of the API calls and display them in a friendly manner.<br/>
e.g. A small web page loads and displays a few buttons to press:
- A button that calls and displays results of the TasksController endpoint
- A button that calls and displays results of Report 1
- A button that calls and displays results of Report 2

If you have some HTML/CSS experience you'd like to demonstrate please feel free to show a little example by styling the basic web front end created above.
<br/><br/>

# IOC Exercise
## Scenario

Implement a single counter that resets and increments on every request to the /Tasks endpoint.

Increment the counter at the start of the following methods:
* TasksController.Get()
* DoWorkService.DoWork()
* MockDataRepository.Save()

The result from /Tasks should include the number of times the counter has been incremented.
<br/><br/>

# Reporting Exercise
## Scenario

Create two separate reports in the class `ReportService`, based on the supplied customer orders dataset in the `SampleDataRepository`.

After this, create a `ReportController` with two actions, each returning one of the reports from the `ReportService`.
<br/><br/>

### Report 1 - Order totals by Customer

The 1st report is a list of orders by customer, showing the total number of orders and a sum of the order total.

For example if customer 5 had 2 orders of $25 each, the source data would look like this:

| Customer Id | Order Id | Order Total | Order Date |
| ----------- | ----------- | ----------- | ----------- |
| 5 | 2994 | $25 | 15/01/2021 7:15 AM |
| 19 | 2995 | $10 | 15/01/2021 9:30 AM |
| 5 | 2996 | $25 | 16/01/2021 12:01 PM |

<br>

The output should show this:

| Customer Id | Order Count | Total |
| ----------- | ----------- | ----------- |
| 5   | 2 | $50 |
| 19  | 1 | $10 |

<br/>

### Report 2 - Order totals by Date

The 2nd report needs to show a count of all the orders and sum all the totals, broken down by date.

Using the sample data shown in report 1, the output should look like this:

| Order Date | Order Count | Order Total |
| ----------- | ----------- | ----------- |
| 15/01/2021 | 1 | $35 | 
| 16/01/2021 | 1 | $25 | 
