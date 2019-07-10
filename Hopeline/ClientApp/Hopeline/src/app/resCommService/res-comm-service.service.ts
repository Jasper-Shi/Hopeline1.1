import { Injectable } from '@angular/core';
import { IResourceCategory } from '../interfaces/IResourceCategory';
import { IResource } from '../interfaces/IResource';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
//import { AuthenticationService } from '@/_services';

@Injectable({
  providedIn: 'root'
})
export class ResCommServiceService {
  private url = "http://localhost:57905/api/";
  //private url = "http://localhost:5000/api/";
  constructor(private _http: HttpClient) { }

  getAllResourceCategories(): Observable<IResourceCategory[]> {
    return this._http.get<IResourceCategory[]>(this.url + "rescomm/getallrescates");
  }
  getAllResources(): Observable<IResource[]> {
    return this._http.get<IResource[]>(this.url + "rescomm/getallres");
  }
}
