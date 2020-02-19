module Exercism.TestRunner.FSharp.Core

type TestStatus =
    | Pass
    | Fail
    | Error

type TestResult =
    { Name: string
      Message: string option
      Output: string option
      Status: TestStatus }

type TestRun =
    { Message: string option
      Status: TestStatus
      Tests: TestResult list }
    
type TestRunContext =
    { InputFile: string
      TestFile: string
      ProjectFile: string
      ResultsFile: string }