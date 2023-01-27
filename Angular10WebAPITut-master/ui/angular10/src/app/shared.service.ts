import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class SharedService {
readonly APIUrl="http://localhost:53535/api";
readonly PhotoUrl = "http://localhost:53535/Photos/";

  constructor(private http:HttpClient) { }

  getDepList():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/department');
  }

  addDepartment(val:any){
    return this.http.post(this.APIUrl+'/Department',val);
  }

  updateDepartment(val:any){
    return this.http.put(this.APIUrl+'/Department',val);
  }

  deleteDepartment(val:any){
    return this.http.delete(this.APIUrl+'/Department/'+val);
  }


  getEmpList():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/Employee');
  }

  addEmployee(val:any){
    return this.http.post(this.APIUrl+'/Employee',val);
  }

  updateEmployee(val:any){
    return this.http.put(this.APIUrl+'/Employee',val);
  }

  deleteEmployee(val:any){
    return this.http.delete(this.APIUrl+'/Employee/'+val);
  }


  UploadPhoto(val:any){
    return this.http.post(this.APIUrl+'/Employee/SaveFile',val);
  }

  getAllDepartmentNames():Observable<any[]>{
    return this.http.get<any[]>(this.APIUrl+'/Employee/GetAllDepartmentNames');
  }

  getUsermList():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/userm');
  }

  addUserm(val:any){
    return this.http.post(this.APIUrl+'/Userm',val);
  }

  updateUserm(val:any){
    return this.http.put(this.APIUrl+'/Userm',val);
  }

  deleteUserm(val:any){
    return this.http.delete(this.APIUrl+'/Userm/'+val);
  }

  getDevList():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/Device');
  }

  addDevice(val:any){
    return this.http.post(this.APIUrl+'/Device',val);
  }

  updateDevice(val:any){
    return this.http.put(this.APIUrl+'/Device',val);
  }

  deleteDevice(val:any){
    return this.http.delete(this.APIUrl+'/Device/'+val);
  }
}
