# SerhiiTkachenkoRdlTestProject

API - http://petstore.swagger.io/#/pet

Test Data: This service has preset test data so you can use only it in api calls.
Task:
      1. Explore api and how it operates with test data. You can try it out manually.
      2. Create basic framework for api testing on .Net platform.
      3. Write autotests:
      Method GET:
      1. Positive test for any pet id on your own. Verify response data.
      2. Negative tests which reproduce:
      400 Invalid ID supplied
      404 Pet not found

      Method POST:
      Positive test for adding new pet. Verify response data.
      Method DELETE:
      Positive test for deleting pet by any id on your own. Will be a good point to
      parametrize test and provide set of pet ids to it.
      4. Upload your project to the github and provide a link to it.

Comments:
      1. I'm not using preset test data. It was generated through API in my tests (on live project it can be done in any 
      different way like adding it directly to DB)
      2. As I understand, test design knowledge applying was not included to the task and I did not check all possible 
      scenarios in my tests. For example: missing some not required parameters when sending POST request
      3. Parametrized tests were done using TestCaseSource attribute for POST method but not for DELETE (other tests I did 
      using one dataset directly from test class)
      4. During api exploration (task#1) I've found:
      - It's possible to authorize. But I did not use it in my tests as pet APIs works fine without any keys
      - Bugs(on my opinion). For example GET pet by id: when sending string instead of int server should return 400 but 
      not 404. I did not use such data in my tests to do them "green"
      

