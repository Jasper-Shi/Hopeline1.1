import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IResourceCategory } from '../interfaces/IResourceCategory';
import { IResource } from '../interfaces/IResource';

@Injectable({
  providedIn: 'root'
})
export class AdminResCommService {
  private url = "http://localhost:57905/api/";
  //private url = "http://localhost:5000/api/";
  constructor(private _http: HttpClient) { }
  addResCate(rc: IResourceCategory): Observable<IResourceCategory> {
    var o = { user_code: rc.user_code, category_name: rc.category_name, category_decription: rc.category_decription, enable_flg: rc.enable_flg };
    return this._http.post<IResourceCategory>(this.url + "adminrescomm/addrescates", o);
  }

  editResCate(rc: IResourceCategory): Observable<IResourceCategory> {
    var o = { user_code: rc.user_code, category_name: rc.category_name, category_decription: rc.category_decription, id: rc.id, dateAdded: rc.dateAdded, enable_flg: rc.enable_flg };
    return this._http.put<IResourceCategory>(this.url + "adminrescomm/editrescates", o);
  }

  deleteResCate(rc: IResourceCategory): Observable<void> {
    var o = { user_code: rc.user_code, category_name: rc.category_name, category_decription: rc.category_decription, id: rc.id, dateAdded: rc.dateAdded, enable_flg: rc.enable_flg };
    //return this._http.delete<void>(this.url + "adminrescomm/deleterescates", o);
    return this._http.post<void>(this.url + "adminrescomm/deleterescates", o);
  }

  setResCateFlg(rc: IResourceCategory, flg: number): Observable<void> {
    var o = { user_code: rc.user_code, category_name: rc.category_name, category_decription: rc.category_decription, id: rc.id, dateAdded: rc.dateAdded, enable_flg: flg };
    return this._http.put<void>(this.url + "adminrescomm/setrescateenable", o);
  }

  setResourceActive(r: IResource, flg: number): Observable<void> {
    var o = { id: r.id, enabled_flg: flg};
    return this._http.put<void>(this.url + "adminrescomm/setresenable", o);
  }

  addRes(res: IResource): Observable<void> {
    const uploadData = new FormData();
    uploadData.append('myFile', res.imageInput, "img");
    var o = { id: res.id, DateAdded: res.DateAdded, user_code: res.user_code, title: res.title, url: res.url, enabled_flg: res.enabled_flg, resource_CategoryId: res.resource_CategoryId, imageInput: uploadData, desc: res.desc };
    return this._http.post<void>(this.url + "adminrescomm/addres", o);
  }

  deleteRes(res: IResource): Observable<void> {
    var o = { id: res.id, DateAdded: res.DateAdded, user_code: res.user_code, title: res.title, url: res.url, enabled_flg: res.enabled_flg, resource_CategoryId: res.resource_CategoryId, image: res.image, desc: res.desc };
    return this._http.post<void>(this.url + "adminrescomm/deleteres", o);
  }
}
