import { Component, OnInit } from '@angular/core';
import { IResourceCategory } from '../interfaces/IResourceCategory';
import { IResource } from '../interfaces/IResource';
import { ResCommServiceService } from '../resCommService/res-comm-service.service';

@Component({
  selector: 'app-resources',
  templateUrl: './resources.component.html',
  styleUrls: ['./resources.component.css']
})
export class ResourcesComponent implements OnInit {
  resCates: IResourceCategory[] = [];
  selectedResCates: IResourceCategory;
  resCatesSub: any;
  res: IResource[] = [];
  selectedRes: IResource[] = [];
  resSub: any;
  constructor(private _resCommService: ResCommServiceService) { }

  ngOnInit() {
    this.resCatesSub = this._resCommService.getAllResourceCategories().subscribe((data) => {
      this.resCates = data;
      this.resSub = this._resCommService.getAllResources().subscribe((resdata) => {
        this.res = resdata;
      })
    });
  }

  getClickedResCate(id: number) {
    this.selectedRes = this.res.filter(i => i.resource_CategoryId == id);
  }

  redirectUser(url: string) {
    window.location.href = 'http://' + url;
  }

}
