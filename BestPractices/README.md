# Best Practice Rules

Customized automatic rules using [Tabular Editor's Best Practice Analyzer functionality](https://docs.tabulareditor.com/Best-Practice-Analyzer.html "Best Practice Analyzer").

See general introduction in [official Power BI blog post](https://powerbi.microsoft.com/en-us/blog/best-practice-rules-to-improve-your-models-performance/ "PowerBI.com blog post").

## Purpose 

Running this collection of rules inside [Tabular Editor](https://tabulareditor.com/ "Tabular Editor")'s [Best Practice Analyzer](https://docs.tabulareditor.com/Best-Practice-Analyzer.html "Best Practice Analyzer") will inform you of potential issues to fix or improvements to be made with regard to performance optimization and model design.

## References 
The code is this repository is based on the following main sources (combined, adjusted, extended, and tested):
1. [Best practice rules on Microsoft Analysis Services GitHub](https://github.com/microsoft/Analysis-Services/tree/master/BestPracticeRules)
2. [Best practice rules on Tabular Editor GitHub](https://github.com/TabularEditor/BestPracticeRules)
3. [Supporting scripts by M.Kovalsky from Power BI Customer Advisory Team at Microsoft](https://github.com/m-kovalsky/Tabular)

## Feedback

Please share your feedback: ReinsightRD@reinsight.se.

In case of issues or specific requests: [submit an issue](https://github.com/Reinsight-SE/Tabular/issues "submit an issue") within this repository.

## Setup (automated)

Following these steps will automatically load the Best Practice Rules into your local Tabular Editor. Note that this will overwrite the existing BPARules.json file (if you are already have one).

1. Open [Tabular Editor](https://tabulareditor.com/ "Tabular Editor").
2. Connect to a model.
3. Run the code from [LoadBPARules.cs](https://github.com/Reinsight-SE/Tabular/raw/main/BestPractices/LoadBPARules.cs) in [Advanced Scripting](https://docs.tabulareditor.com/Advanced-Scripting.html "Advanced Scripting") window.
4. Close and reopen [Tabular Editor](https://tabulareditor.com/ "Tabular Editor").
5. Connect to a model.
6. Select 'Tools' from the File menu and select 'Best Practice Analyzer'.
7. Click the Refresh icon (in blue).

## Setup (manual)

1. Download the BPARules.json file from GitHub (in this repository).
2. Within the Start Menu, type %localappdata% and click Enter.
3. Navigate to the 'TabularEditor' folder (if using Tabular Editor 3, navigate to the TabularEditor3 folder).
4. Copy the rules file (.json) and paste it into the folder from Step 3.*
5. Open [Tabular Editor](https://tabulareditor.com/ "Tabular Editor") and connect to your model.
6. Select 'Tools' from the File menu and select 'Best Practice Analyzer'.
7. Click the Refresh icon (in blue).

## Notes

* The following rules require running an additional script before running the Best Practice Analyzer

  * Avoid bi-directional relationships against high-cardinality columns *
  * Large tables should be partitioned *
  * Reduce usage of long-length columns with high cardinality *^
  * Split date and time ***
  
  *These rules use [Vertipaq Analyzer](https://www.sqlbi.com/tools/vertipaq-analyzer/) data. There are 2 methods to load this data into Tabular Editor:
 
  1. Load Vertipaq Analyzer data directly from a server ([instructions](https://www.elegantbi.com/post/vertipaqintabulareditor)) ([script](https://github.com/m-kovalsky/Tabular/blob/master/VertipaqAnnotations.cs)).
  
  2. Load Vertipaq Analyzer data from .vpax file ([instructions](https://www.elegantbi.com/post/vpaxtotabulareditor)) ([script](https://github.com/m-kovalsky/Tabular/blob/master/VpaxToTabularEditor.cs)).
  
  ^Run this [script](https://github.com/m-kovalsky/Tabular/blob/master/BestPracticeRule_LongLengthColumns.cs "script") while live-connected to the model.
  
  ***Run this [script](https://github.com/m-kovalsky/Tabular/blob/master/BestPracticeRule_SplitDateAndTime.cs "script") while live-connected to the model.
  
## Requirements

[Tabular Editor](https://tabulareditor.com/ "Tabular Editor") version 2.16.1 or higher.

## Version History

* 2021-07-30 Version 1.0
