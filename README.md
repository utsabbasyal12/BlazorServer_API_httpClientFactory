# BlazorServer_API_httpClientFactory
This project demonstrate how to get baseaddress from appsetting.json using httpclientfactory

# In Program.cs
![image](https://github.com/utsabbasyal12/BlazorServer_API_httpClientFactory/assets/45966409/193733e9-1ff4-40b3-8684-8c02396c2fe4)

If your project use WebApplication.CreateBuilder then this project completely work.


![image](https://github.com/utsabbasyal12/BlazorServer_API_httpClientFactory/assets/45966409/14beba5d-9666-4042-be2d-731433e8b991)

But, If your project use WebAssemblyHostBuilder.CreateDefault() then there is another approach to get url from appsetting.json 

Steps:
  1. Create a appsettings.json file inside a wwwroot folder

![image](https://github.com/utsabbasyal12/BlazorServer_API_httpClientFactory/assets/45966409/c5f648c7-3793-4cb1-aa48-3ff450749b98)

  3. Add urls inside the newly created appsettings.json file
 
 ![image](https://github.com/utsabbasyal12/BlazorServer_API_httpClientFactory/assets/45966409/361a1132-df56-49b9-a6d2-1f5de56ae16b)

  5. Create a static method in program.cs to get response from appsettings.json file

![image](https://github.com/utsabbasyal12/BlazorServer_API_httpClientFactory/assets/45966409/4731c4e8-5928-4aed-bf00-85085a62f8d3)

  6. Call this method in main method

![image](https://github.com/utsabbasyal12/BlazorServer_API_httpClientFactory/assets/45966409/44047287-6206-47dd-b0c0-9c4d1886be42)

  8. Rest of the code is same and don't forget to add HttpClient

![image](https://github.com/utsabbasyal12/BlazorServer_API_httpClientFactory/assets/45966409/8aeacf61-0671-410f-8030-47603f69e066)

  9. The UI services look like this

![image](https://github.com/utsabbasyal12/BlazorServer_API_httpClientFactory/assets/45966409/ce40e79b-faa5-45e4-8120-9e0e1ce329b5)
