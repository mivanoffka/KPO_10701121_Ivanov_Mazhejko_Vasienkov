#pragma once
#include <iostream>                  
#include "Model.h"                                               
// View is responsible to present data to users
class View {
public:
    View(const Model& model) {
        this->model = model;
    }
    View() {}
    void SetModel(const Model& model) {
        this->model = model;
    }
    void Render() {
        std::cout << "Model Data = " << model.Data() << endl;
    }
private:
    Model model;
};
