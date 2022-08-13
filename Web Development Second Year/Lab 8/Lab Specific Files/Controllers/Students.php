<?php

namespace App\Controllers;

use App\Models\StudentsModel;

class Students extends BaseController
{
    
    public function index()
    {
        $model = model(StudentsModel::class);
    
        $data = [
            'students2'  => $model->getStudents(),
        ];
    
        echo view('templates/header', $data);
        echo view('students/overview', $data);
        echo view('templates/footer', $data);
    }

    public function view($slug = null)
    {
        $model = model(StudentsModel::class);

        $data['students2'] = $model->getStudents($slug);

        if (empty($data['students2'])) {
            throw new \CodeIgniter\Exceptions\PageNotFoundException('Cannot find the student item: ' . $slug);
        }
    
        $data['FirstName'] = $data['students2']['FirstName'];
    
        echo view('templates/header', $data);
        echo view('students/view', $data);
        echo view('templates/footer', $data);
    }
}