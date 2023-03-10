#include <iostream>
#include "View.h"
#include "Model.h"
#include "Controller.h"
#include "Common.h"

using namespace std;
void DataChange(string data) {
    	cout << "Data Changes: " << data << endl;
}

int main() {
	Model model("Model");
  	View view(model);
   	// register the data-change event
   	model.RegisterDataChangeHandler(&DataChange);
   	// binds model and view.
    Controller controller(model, view);
   	// when application starts or button is clicked or form is shown...
   	controller.OnLoad();
    model.SetData("Changes"); // this should trigger View to render
	return 0;
}
