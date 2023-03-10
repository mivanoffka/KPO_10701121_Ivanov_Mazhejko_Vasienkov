#pragma once
#include "Model.h"
#include "View.h"

// Controller combines Model and View
class Controller {
public:
    Controller(const Model& model, const View& view) {
        this->SetModel(model);
        this->SetView(view);
    }
    void SetModel(const Model& model) {
        this->model = model;
    }
    void SetView(const View& view) {
        this->view = view;
    }
    // when application starts
    void OnLoad() {
        this->view.Render();
    }
private:
    Model model;
    View view;
};
