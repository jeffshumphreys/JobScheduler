# JobScheduler
Quartz.NET implementation to run my SQL Scripts better than SQL Agent does.

## What's Available
Because SQL Agent:
- Drives me crazy
- Doesn't easily show running job status
- Doesn't show you the currently running step in Log File Viewer
    ![Example](/Images/Documentation/SQLAgentJobLogNoCurrentStep.png)
- About 200 characters max in Job description.
- Can't pass parameters into an execution.
- I have job categories, but no tree view to show them as a hierarchy

Control-M:
- Is Enterprise.  Scheduling should be RAD, not locked down into multiple blind releases.

Windows Task Scheduler:
- I've seen this used at companies, Private companies even.  So I will use the API to pull if any are available.

cron:
- I know some servers use this, linux for one.

at:
- Anyone use?

Azure RunBooks:
SSIS Package internal tasks:


https://stackoverflow.com/questions/7653483/github-relative-link-in-markdown-file#7658676

## Targeted Interface
- WinForms for now.  I'm looking at WPF XAML hand-coding without MVVM as a RAD method-o-log-y.
- SQL Server for storage. It's what I know.
- .NET 4.8  Quartz.NET isn't compatible with .NET 5 or .NET Core.
- Windows only. Without .NET Core I don't want to consider linux.

## Integrations
- Severely limited for now.  If I don't need it I'm not writing it today.

## Desired Features
- Toast notifications.  They stay up (some) until I click them.
- Blinking objects. Alert me!
- File watcher jobs.
- Event log watcher jobs.
- 
- Tree view of jobs
- Support for Control-m and SQL Agent jobs in the same tree and flow.
    - So kick a local SQL Agent job when an enterprise control-m job fails.
- Async. Quartz.NET supports this out of box.
- Monitor view when I kick a job.  Unlike SQL Agent, it stays open when I select a step to start on, and I can watch, I can system pin it.
- No modal dialogs.
- Annotate any job, any step.
- Add another level called phase, under a step.  Some steps are majorly complex, so this is a tracking point for when the step fails.
- Different Job Run Expectations:
    - All steps must complete or fail job.
- Restart options
    - Restart on any failure n times
    - Delay between restarts
    - Queries controlling restart window
    - Restart Step/Job if transient error ("Out of memory")
        - Restart max number of times depending on error. out of memory in SQL Agent from SSMS manual start should only need ONE restart.  2 has never happened.
- Interactive options???
    - Just hypothetical for now.
        - "Enter password for this step to continue.  You have 10 seconds."
        - Email: "Click YES to authorize advance in step sequence"
- Colors on UI!
    - Red Job name means failing
    - Green Job name means succeeded. Orange, glowing - Running and succeeded last scheduled time.
- Full self-visibility.
    - In each Job and step, the code can reference
        - current Job name, previous Job, last time successful on scheduled
        - Is this run scheduled or a retry?  Retry #?
        - How did I start? command line, email, external email, manual in SSMS, manual from Query SP run
        - Did this run start unusually close to a previous run?  As in, denial of service?
        - Are resources behaving weird?
- Job Folders
- Easy reports
    - Show me today's runs, last weeks, since start of business week, weekend, failed runs, slow runs
   
        
