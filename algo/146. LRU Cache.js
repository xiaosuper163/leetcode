// @9 hashmap
// always remember to set both prev and next while using double linked list

function Node(key, val) {
    this.key = key;
    this.val = val;
    this.next = null;
    this.prev = null;
}

/**
 * @param {number} capacity
 */
var LRUCache = function(capacity) {
    this.capacity = capacity;
    this.helper_dict = {};
    this.head = null;
    this.tail = null;
    this.currSize = 0;
};

/** 
 * @param {number} key
 * @return {number}
 */
LRUCache.prototype.get = function(key) {
    if (this.helper_dict.hasOwnProperty(key)) {
        if (this.helper_dict[key] === this.tail) {
            return this.helper_dict[key].val;
        }
        var temp = this.helper_dict[key].prev;
        if (temp !== null) {
            temp.next = temp.next.next;
            temp.next.prev = temp;
        } else {
            this.head = this.helper_dict[key].next;
            this.head.prev = null;
        }
        this.tail.next = this.helper_dict[key];
        this.helper_dict[key].prev = this.tail;
        this.tail = this.helper_dict[key];
        this.tail.next = null;
        return this.helper_dict[key].val;
    }
    return -1;
};

/** 
 * @param {number} key 
 * @param {number} value
 * @return {void}
 */
LRUCache.prototype.put = function(key, value) {
    //console.log(this.helper_dict);
    //console.log(this.currSize);
    if (this.helper_dict.hasOwnProperty(key)) {
        this.helper_dict[key].val = value;
        this.get(key);
        return;
    } else {
        this.currSize++;
        var node = new Node(key, value);
        if (this.head == null && this.tail == null) {
            this.head = node;
            this.tail = node;
        } else {
            this.tail.next = node;
            node.prev = this.tail;
            this.tail = node;
        }
        this.helper_dict[key] = node;
        //console.log('currSize', this.currSize, 'capacity', this.capacity, 'this key', key, 'head key', this.head.key);
    }
    if (this.currSize > this.capacity) {
        var tempKey = this.head.key;
        this.head = this.head.next;
        this.head.prev = null;
        delete this.helper_dict[tempKey];        
        this.currSize--;
    }
};

/** 
 * Your LRUCache object will be instantiated and called as such:
 * var obj = Object.create(LRUCache).createNew(capacity)
 * var param_1 = obj.get(key)
 * obj.put(key,value)
 */