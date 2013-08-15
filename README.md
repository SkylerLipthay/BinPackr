# BinPackr

## Synopsis

BinPackr is a basic attempt to attack the NP-hard problem regarding efficiently sorting a finite number of two-dimensional rectangles into a larger two-dimensional container rectangle. There is no way to solve this problem within a reasonable time frame, as the only method involves using brute force to arrange every rectangle in every possible position in hopes of finding the tightest packed solution. Even if a computer was capable of such a brute force method, it is not even guaranteed that the bins can be perfectly packed within a container.

## Algorithm

Regardless of the problem’s difficulty, BinPackr attacks using a greedy algorithm which involves recursively dividing the container field into smaller divisions by internally using a binary tree structure which is also handy for quick traversing.

- Place the first rectangle at the top left corner of the container.
- Split the container horizontally and vertically around the placed rectangle, storing the divisions as nodes in a tree leading to a pointer to the rectangle as a leaf.
- Check if the next rectangle can fit in the same horizontal row as the previous rectangle. If not, place the next rectangle underneath the previous rectangle.
- If the new rectangle was able to fit in the same division, add a pointer to the rectangle under the second division of the binary tree node corresponding to the appropriate division.
- If the new rectangle was not able to fit in the same division, divide the container again. As before, insert nodes representing the divisions leading to a pointer to the new rectangle as a leaf.
- Repeat until all rectangles have been placed. If a rectangle cannot fit, place it underneath the container as an unresolved bin.

In this implementation, unresolved bins are organized, but not sorted, underneath the container.

## Usage

BinPackr was programmed in C#.NET using Microsoft Visual Studio 2010 under a Windows 7 environment. BinPackr will only run on a Windows operating system with the .NET 2.0 runtime installed, which has been included by default in home operating system distributions ever since Windows Vista.

![BinPackr after an average execution.](www/screenshot.png?raw=true)

The container size is adjustable under Panel Size, but is sized by default at 521px by 350px to fit the window most efficiently. To begin normal operation, select a rectangle size range under Populate, enter the desired number of rectangles to generate, and click Generate Blocks. By clicking Show Log under Operate, information regarding the newly populated container will be displayed. The log is primarily used for providing information regarding the efficiency of sort attempts. Scramble can be used to randomly place the existing rectangles around the container to simulate an unsorted array of bins.

To sort all of the rectangles in the container, click Sort. The log will be populated with the success rate of the sorting (all rectangles will be placed successfully if the panel size is large enough) along with the new compacted bounding area of all the bins. This information can be compared to previous data given after block generation or scrambling.

## Code

As mentioned, BinPackr was coded in C# and compiled using Microsoft Visual Studio 2010. The included code (.cs files) can be viewed simply using a text editor. The main point of interest (the main sorting algorithm) is viewable within BinListSorterTree.cs under the Sort function.