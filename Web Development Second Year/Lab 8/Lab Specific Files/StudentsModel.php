<?php

namespace App\Models;

use CodeIgniter\Model;

class StudentsModel extends Model
{
    protected $table = 'students2';

    public function getStudents($slug = false)
{
    if ($slug === false) {
        return $this->findAll();
    }

    return $this->where(['slug' => $slug])->first();
}
}