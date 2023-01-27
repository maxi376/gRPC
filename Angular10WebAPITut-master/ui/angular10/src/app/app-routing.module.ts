//import { UsermComponent } from './userm/userm.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import {EmployeeComponent} from './employee/employee.component';
import {DepartmentComponent} from './department/department.component';
import {UsermComponent} from './userm/userm.component';
import {DeviceComponent} from './device/device.component';


const routes: Routes = [
{path:'employee',component:EmployeeComponent},
{path:'department',component:DepartmentComponent},
{path:'userm',component:UsermComponent},
{path:'device',component:DeviceComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
