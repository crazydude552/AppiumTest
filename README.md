# Introduction 
2 sample projects 
1.AppiumTest(sample tests to test the webapp in webbrowser on Genymotion emulator)
2.TestAppium(sample tests to test the webapp and apk in on Genymotion emulator)
This solution created a sample testing application with Specflow for Testing webbrowser on Genymotion emulator

# Getting Started
To start the project on local need to have following dependencies
1.Dotnet sdk
2.Android sdk
3.Appium server installed and started
4.Genymotion emulator installed or running in cloud(Please follow the below steps for cloud)
5.Chrome browser must be installed in Emulator, you can direcly download apk and drag and drop to emulator
6.calculator app in emulator you can download apk and drag and drop to emulator
6.Chromedriver exe must be available in local and must provide the path in capabilities to initialize browser


# Build and Test
To run the test 
command:dotnet test (on the project directory path)

Options.AddAdditionalCapability("deviceName", "Samsung Galaxy S8");
Options.AddAdditionalCapability("platformName", "Android");
Options.AddAdditionalCapability("appPackage", "com.google.android.calculator");
Options.AddAdditionalCapability("appActivity", "com.android.calculator2.Calculator");
#if running in cloud need to provide the emulator device UUID
Options.AddAdditionalCapability("UUID", "b7e38999-06f7-4e81-864c-0c32a9d1d0e4");
#or
#if running in local need to provide the emulator device udid
Options.AddAdditionalCapability("udid", "192.168.181.103:5555");

#Running in Genymotion cloud
1.Create an account in Cloud
2.open cmd in admin mode
3.python.exe -m pip install --upgrade pip
https://docs.genymotion.com/gmsaas/01_Get_Started/
4.pip install gmsaas
5.gmsaas config set android-sdk-path C:\Program Files (x86)\Android\android-sdk
6.you can set the path for andorid sdk and looks like below after setup
C:\WINDOWS\system32>gmsaas config set android-sdk-path $ANDROID_HOME
'android-sdk-path' has been set to 'C:\Program Files (x86)\Android\android-sdk'.
7.verify the instances which you are running on cloud after login with the credentials
gmsaas instances list
8.need to set a port if needed to specify
gmsaas instances adbconnect --adb-serial-port 5554 b7e38999-06f7-4e81-864c-0c32a9d1d0e4
localhost:5554
9.Verify the instances
C:\WINDOWS\system32>gmsaas instances list
UUID                                  NAME            ADB SERIAL      STATE
------------------------------------  --------------  --------------  -------
b7e38999-06f7-4e81-864c-0c32a9d1d0e4  Google Pixel 3  localhost:5554  ONLINE
10.Now you can add UUID in the application.

 Options.AddAdditionalCapability("UUID", "b7e38999-06f7-4e81-864c-0c32a9d1d0e4");

More details in the WIKI
https://dev.azure.com/ITGlo/Competence%20Leads/_wiki/wikis/Competence-Leads.wiki/1152/Mobile-Automation-UI-Test