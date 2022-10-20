variable "rg_01_name" {
    type = string
  default = "rg-myproject-01"
}
variable "rg_01_location" {
    type = string
  default = "west us3"
}
variable "vnet_01_name" {
    type = string
    default = "vnet-myproject-wus3-01"
  
}
variable "vnet_01_address_space" {
  type = list(string)
  default = [ "10.0.0.0/16" ]
}
variable "subnet_01_name" {
  type = string
  default = "subnet1"
}
variable "subnet_01_address_perfix" {
  type = list(string)
  default = ["10.0.1.0/24"]

}
variable "tag_env_name" {
  type = string
  default = "development"
}
variable "nic_01_name" {
  type = string
  default ="nic-myproject-wus3-01"
}
variable "private_ip_address" {
  type = string
  default = "10.0.1.0"
}
variable "nsg_01_name" {
  type = string
  default = "nsg-myproject-wus3-01"
}
variable "vm_01_name" {
  type = string
  default = "vm-myproject-01"
}
variable "pip_01_name" {
  type = string
  default = "pip-myproject-wus3-01"
}