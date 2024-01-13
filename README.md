<a name="readme-top"></a>

<!-- PROJECT SHIELDS -->
[![LinkedIn][linkedin-shield]][linkedin-url]

<!-- PROJECT LOGO -->
<br />
<div align="center">
  <h3 align="center">Stock Analyzer</h3>

  <p align="center">
    Analyze multiple stock patterns for stock patterns
    <br />
    <br />
    <a href="https://github.com/othneildrew/Best-README-Template/issues">Report Bug</a>
    ·
    <a href="https://github.com/othneildrew/Best-README-Template/issues">Request Feature</a>
  </p>
</div>


<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#acquired-concepts">Acquired Concepts</a></li>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#contact">Contact</a></li>
  </ol>
</details>


<!-- ABOUT THE PROJECT -->
## About The Project

<!-- [![Product Name Screen Shot][product-screenshot]](https://example.com) -->
<!-- ![Screenshot 2023-02-02 231445](https://user-images.githubusercontent.com/21976362/216513477-2bd9a162-329b-43fa-9ea7-6c0a18e5c659.png) -->
<!--

Quickly chat with anyone over the internet with little setup. This project helped me learn TailwindCSS, conditional rendering in React, and the Firebase authentication.
-->
<p align="right">(<a href="#readme-top">back to top</a>)</p>

### Acquired Concepts
* Polymorphism - Implementing pattern recognition via abstract classes and derived concrete classes is a key goal. Students need to demonstrate understanding of polymorphism and when/how to apply it.
* Inheritance - Smart candlestick class must inherit from base candlestick class to avoid rewriting and demonstrate understanding of inheritance.
* Abstraction - Use of abstract classes and interfaces to define common APIs.
* Encapsulation - Breaking up functionality into separate well-defined methods instead of one large complex method.
* Data Binding - Using data binding to connect data to the UI instead of manual additions.
* Event-driven programming - Allowing user to trigger events (like selecting a pattern) that drive application behavior.

### Built With

 * Windows Forms (.Net Framework using C#)
   
<!-- USAGE EXAMPLES -->

## Usage
![Screenshot 2024-01-13 141447](https://github.com/YingJames/StockAnalyzer/assets/21976362/0acb01c3-fb4c-4a35-b43e-8326164e9840)
The application allows analyzing and visualizing stock data to identify candlestick patterns. The main workflow is as follows:
Loading Stock Data

* Use the Open File Dialog to select one or more stock data files to load
* Stock data for multiple symbols can be loaded and analyzed

Visualizing Stocks

* The selected stock symbols are each displayed in a separate window in candlestick chart format for analysis
* The charts display the Open, High, Low and Close values for each candlestick time period

Applying Filters

* Date range filters can be applied to only show the candlesticks in a specific date range

Selecting Patterns

* Single and multi-candlestick patterns can be selected for pattern recognition from the dropdown combobox
* Available single candlestick patterns include bearish, bullish, neutral, marubozu, doji, gravestone doji, dragonfly doji, hammer, and inverted hammer
* Available multi-candlestick patterns include bearish and bullish engulfing, bearish and bullish harami, peak, and valley

Analyzing Patterns

* Once a pattern is selected, the charts are analysis and the identified patterns are annotated
The annotation highlights the candlesticks forming the specified pattern

Analyzing Multiple Stocks

* The above workflow allows comparing multiple stock charts side-by-side in separate windows

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- CONTACT -->
## Contact

James Yab - [LinkedIn](https://www.linkedin.com/in/james-yab/) - jamesy148@usf.edu

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/in/james-yab/
