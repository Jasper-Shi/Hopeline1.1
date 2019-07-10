export interface IResource {
  id: number;
  DateAdded: string;
  user_code: string;
  image: string;
  imageInput: File;
  title: string;
  desc: string;
  url: string;
  enabled_flg: number;
  resource_CategoryId: number;
  resource_CategoryName: string
}
